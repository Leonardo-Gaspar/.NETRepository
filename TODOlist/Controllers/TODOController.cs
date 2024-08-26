using Microsoft.AspNetCore.Mvc;

 
namespace TODOList.Controllers
{
    public class TODOController : Controller
    {
        private readonly dbContext _context;
        public TODOController(dbContext context)
        {
            _context = context;
        }

        List<TODO> TODOs = new List<TODO>   
        {
            new TODO { Id = 1, Tarefa = "Estudar C#", Descricao = "Estudar C# para melhorar o desenvolvimento de aplicações", Feito = false },
            new TODO { Id = 2, Tarefa = "Estudar ASP.NET Core", Descricao = "Estudar ASP.NET Core para melhorar o desenvolvimento de aplicações", Feito = false },
            new TODO { Id = 3, Tarefa = "Estudar Entity Framework", Descricao = "Estudar Entity Framework para melhorar o desenvolvimento de aplicações", Feito = false },
            new TODO { Id = 4, Tarefa = "Estudar Razor", Descricao = "Estudar Razor para melhorar o desenvolvimento de aplicações", Feito = false },
            new TODO { Id = 5, Tarefa = "Estudar MVC", Descricao = "Estudar MVC para melhorar o desenvolvimento de aplicações", Feito = false },
        };
        public IActionResult Index()
        {
            var AllTodos = _context.TODOs.ToList();
            if(AllTodos == null){
                return RedirectToAction("Index", "Home");
            }      
            return View(AllTodos);
        }
        public IActionResult Create(TODO todo){

            var newTodo = new TODO{
                Tarefa = todo.Tarefa,
                Descricao = todo.Descricao,
                Feito = todo.Feito
            };
            _context.TODOs.Add(newTodo);
            _context.SaveChanges();

            return View();
            
        }
    }
}


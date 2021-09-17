using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCore3._1SwaggerKullanimi.Model;

namespace NetCore3._1SwaggerKullanimi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public List<TodoItem> GetAllTodoItems()
        {
            var responseList = new List<TodoItem>
            {
                new TodoItem{
                    Key="SD2",
                    Name="Görev1",
                    IsComplete=true,
                },
                new TodoItem{
                    Key="SD11",
                    Name="Görev2",
                    IsComplete=true,
                },
                new TodoItem{
                    Key="SD251",
                    Name="Görev3",
                    IsComplete=true,
                },
                new TodoItem{
                    Key="SD8",
                    Name="Görev4",
                    IsComplete=true,
                },
                new TodoItem{
                    Key="SD01",
                    Name="Görev5",
                    IsComplete=true,
                },
                new TodoItem{
                    Key="SD42",
                    Name="Görev6",
                    IsComplete=true,
                },
            };

            return responseList;
        }


    }
}
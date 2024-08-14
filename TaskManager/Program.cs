using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Id}: {Description}";
        }
    }
}
namespace TaskManager
{
    public class TaskManager
    {
        private readonly List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(string description)
        {
            var task = new Task { Id = nextId++, Description = description, IsCompleted = false };
            tasks.Add(task);
            Console.WriteLine($"Tarefa '{description}' adicionada com sucesso!");
        }

        public void ViewTasks()
        {
            Console.WriteLine("Tarefas Pendentes:");
            foreach (var task in tasks.Where(t => !t.IsCompleted))
            {
                Console.WriteLine(task);
            }

            Console.WriteLine("\nTarefas Concluídas:");
            foreach (var task in tasks.Where(t => t.IsCompleted))
            {
                Console.WriteLine(task);
            }
        }

        public void CompleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.MarkAsCompleted();
                Console.WriteLine($"Tarefa '{task.Description}' marcada como concluída.");
            }
            else
            {
                Console.WriteLine($"Tarefa com ID {id} não encontrada.");
            }
        }

        public void RemoveTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine($"Tarefa '{task.Description}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa com ID {id} não encontrada.");
            }
        }
    }
}
namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            string option;

            do
            {
                Console.WriteLine("\nTask Manager - Escolha uma opção:");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Visualizar Tarefas");
                Console.WriteLine("3. Marcar Tarefa como Concluída");
                Console.WriteLine("4. Remover Tarefa");
                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Descrição da Tarefa: ");
                        string description = Console.ReadLine();
                        taskManager.AddTask(description);
                        break;

                    case "2":
                        taskManager.ViewTasks();
                        break;

                    case "3":
                        Console.Write("ID da Tarefa para marcar como concluída: ");
                        int completeId = int.Parse(Console.ReadLine());
                        taskManager.CompleteTask(completeId);
                        break;

                    case "4":
                        Console.Write("ID da Tarefa para remover: ");
                        int removeId = int.Parse(Console.ReadLine());
                        taskManager.RemoveTask(removeId);
                        break;

                    case "0":
                        Console.WriteLine("Saindo do Task Manager...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            } while (option != "0");
        }
    }
}

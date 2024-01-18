using System;
using System.Collections.Generic;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
}

public class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void EditTask(int index, Task updatetTask)
    {
        if(index >= 0 && index < tasks.Count)
        {
            tasks[index] = updatetTask;
        }
    }

    public void DeleteTask(int index)
    {
        if(index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
        }
    }

    public void MarkTaskAsCompleted(int index)
    {
        if(index >= 0 && index < tasks.Count)
        {
            tasks[index].IsCompleted = true;
        }
    }

    public void DisplayTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Title: {task.Title}, Description: {task.Description}, Due Date: {task.DueDate}, Completed: {task.IsCompleted}");
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        taskManager.AddTask(new Task { Title = "Task 1", Description = "Description for Task 1", DueDate = DateTime.Now.AddDays(3) });
        taskManager.AddTask(new Task { Title = "Task 2", Description = "Description for Task 2", DueDate = DateTime.Now.AddDays(5) });

        Console.WriteLine("Tasks:");

        taskManager.DisplayTasks();

        Console.ReadLine();
    }
}
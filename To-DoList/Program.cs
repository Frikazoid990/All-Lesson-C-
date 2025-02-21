using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading;
using System.Runtime.InteropServices;

namespace To_DoList
{
    internal class Program
    {
        
        public static ApplicationContext db = new ApplicationContext();
        public static List<Note> Tasks = db.Note.ToList();

        static public void Update(ApplicationContext db, ref List<Note> Tasks)
        {
            Console.Clear();
            Tasks = db.Note.ToList(); 
            if (Tasks.Count == 0)
            {
                Console.WriteLine("Пока что тут записей нет(\n" +
                    "Добавьте запись нажав кнопку 1");
            }
            else
            {

                Console.WriteLine
                ("To-Do List\n" +
                "1. Добавить запись\n" +
                "2. Удаить запись\n" +
                "3. Редактировать запись\n" +
                "Записи:\n");
                for (int i = 0; i < Tasks.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {Tasks[i].text}\n");
                }
            }
        }

        static public void AddEntry(ApplicationContext db)
        {
            Console.Clear();
            Console.WriteLine("Ваша заметка...");
            string text = Console.ReadLine();
            if (text != null & text != "")
            {

                Note entry = new Note()
                {
                    text = text,
                };
                db.Note.Add(entry);
                db.SaveChanges();
                Console.WriteLine($"Добавлено");
            }
            else
            {
                Console.WriteLine("Текст не был введен");
            }
        }

        static public void DeleteEntry(ApplicationContext db, List<Note> Tasks)
        {
            Console.WriteLine("Введите номер заметки которую хотите удалить");
            int numb = Convert.ToInt32(Console.ReadLine()) - 1;
            if (numb <= Tasks.Count && numb >= 0) 
            {
                Console.Clear();
                Note task = Tasks[numb];
                Console.WriteLine($"Вы точно хотите удалить запись?\n" +
                    $"{numb+1}. {task.text}\n" +
                    $"Y/N");
                string yesorno = Console.ReadLine();
                if (yesorno == "Y" || yesorno == "y")
                {
                  if(task != null) {db.Note.Remove(task); db.SaveChanges(); }
                    Console.WriteLine("Запись удалена");
                }
                else if (yesorno == "N" || yesorno == "n")
                {
                    Console.WriteLine("Отмена");
                }
                else
                {
                    Console.WriteLine("Такой команды нет");
                }
                
            }
            else
            {
                Console.WriteLine("Такого номера нет");
            }
            
            

        }

        static public void EditEntry(ApplicationContext db, List<Note> Tasks)
        {
            
            Console.WriteLine("Введите номер заметки которую хотите редактировать");
            int numb = Convert.ToInt32(Console.ReadLine()) - 1;
            if (numb <= Tasks.Count && numb >= 0)
            {
                Console.Clear();
                Note task = Tasks[numb];
                Console.WriteLine($"Вы точно хотите отредактировать запись?\n" +
                    $"{numb + 1}. {task.text}\n" +
                    $"Y/N");
                string yesorno = Console.ReadLine();
                if (yesorno == "Y" || yesorno == "y")
                {
                    Console.WriteLine("Введите новый текст:");
                    string uppdatetext = Console.ReadLine();
                    if (task != null) { task.text = uppdatetext; db.SaveChanges(); }
                    Console.WriteLine("Запись отредактирована");
                }
                else if (yesorno == "N" || yesorno == "n")
                {
                    Console.WriteLine("Отмена");
                }
                else
                {
                    Console.WriteLine("Такой команды нет");
                }

            }
            else
            {
                Console.WriteLine("Такого номера нет");
            }
        }


        static void Main(string[] args)
        {

            while (true)
            {
                Update(db,ref Tasks);
                if (Tasks.Count != 0)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            AddEntry(db);
                            break;
                        case ConsoleKey.D2:
                            DeleteEntry(db, Tasks);
                            break;
                        case ConsoleKey.D3:
                            EditEntry(db, Tasks);
                            break;
                        default:
                            Console.WriteLine("Выберете команду");

                            break;

                    }
                }
                else
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            AddEntry(db);
                            break;
                        default:
                            Console.WriteLine("Выберете команду");

                            break;

                    }
                }
                Thread.Sleep(1500);
            }


        }
    }
}

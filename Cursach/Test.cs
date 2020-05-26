using System;
using System.Collections.Generic;
using Coursach.Entities;

namespace Coursach
{
    public static class Test
    {
        public static List<User> Main()
        {
            var subjects = new List<Subject>
            {
                new Subject
                {
                    Id = 1,
                    Name = "Math",
                    HasMark = true
                },
                new Subject
                {
                    Id = 2,
                    Name = "Proga",
                    HasMark = true
                },
                new Subject
                {
                    Id = 3,
                    Name = "Physics",
                    HasMark = false
                }
            };

            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Vlad",
                    LastName = "Krotov",
                    Marks = new List<Mark>
                    {
                        new Mark
                        {
                            IsPassed = true,
                            Subject = subjects[2]
                        },
                        new ExamMark
                        {
                            Subject = subjects[0],
                            Value = 4
                        }
                    }
                }
            };


            foreach (var user in users)
            {
                foreach (var userMark in user.Marks)
                {
                    if (userMark is ExamMark mark)
                    {
                        Console.WriteLine(mark.Value);
                    }
                    
                    Console.WriteLine(userMark.IsPassed);

                }
            }

            return users;
        }
    }
}
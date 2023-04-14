﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Студент
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Группа Группа { get; }
        public string ДатаРождения { get; }
        public Студент(string фамилия, string имя, string отчество, Группа группа, string датаРождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Группа = группа;
            ДатаРождения = датаРождения;
        }
    }
}

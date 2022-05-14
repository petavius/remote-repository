﻿using System;

namespace GitManual.App02.BusinessLogic
{
    internal class LoggingUser
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public DateTime? EmploymentDate { get; set; }
    }
}

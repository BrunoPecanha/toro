﻿using System;

namespace Toro.Domain.Entity {
    public class Investor: To<int> {     
        public string Cpf { get; private set; }
        public int Account { get; private set; }
        public int Branch { get; private set; }
        public int PatrimonyId { get; set; }
        public Patrimony Patrimony { get; private set; }
        public string UserId { get; private set; }
        public User User { get; private set; }

        private Investor() {                 
        }

        public Investor(User user) {
            UserId = user.Id;
            Cpf = user.Cpf;
            Account = new Random().Next(1, 100000);
            Branch = 0001;
        }

        public bool IsCpfEqual(string cpf) {
            return this.Cpf.Equals(cpf);
        }       
    }
}

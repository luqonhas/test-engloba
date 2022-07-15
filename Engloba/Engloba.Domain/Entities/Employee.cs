using Engloba.Shared.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engloba.Domain.Entities
{
    public class Employee : Base
    {
        public Employee(string name, string cpf, string rg, string issuer, string voterRegistration, string cnh, bool isManager)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(name, "Name", "The 'Name' field cannot be empty!")
                .IsNotEmpty(cpf, "CPF", "The 'CPF' field cannot be empty!")
                .IsNotEmpty(rg, "RG", "The 'RG' field cannot be empty!")
                .IsNotEmpty(issuer, "Issuer", "The 'Issuer' field cannot be empty!")
                .IsNotEmpty(voterRegistration, "VoterRegistration", "The 'VoterRegistration' field cannot be empty!")
                .IsNotEmpty(cnh, "CNH", "The 'CNH' field cannot be empty!")
            );

            Name = name;
            CPF = cpf;
            RG = rg;
            Issuer = issuer;
            VoterRegistration = voterRegistration;
            CNH = cnh;
            IsManager = false;
        }

        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Issuer { get; private set; }
        public string VoterRegistration { get; private set; }
        public string CNH { get; private set; }
        public bool IsManager { get; private set; }


        // Compositions

    }
}

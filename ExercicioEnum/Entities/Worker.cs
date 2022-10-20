using System;
using System.Collections.Generic;
using ExercicioEnum.Entities.Enums;

namespace ExercicioEnum.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        // associação de classes
        public Departament Departament { get; set; }

        // instanciado a lista para garantir que ela não seja vazia
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContracta(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // Income recebe ano e mês e traz a soma dos valores que o usuário recebeu nesse mês/ano
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.TotalValue();
            }

            return sum;
        }
    }
}


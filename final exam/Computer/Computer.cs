using System.Collections.Generic;
using System.Linq;

namespace ComputerArchitecture
{
    public class Computer
    {
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public Computer(string model, int capacity)
        {
            this.Model = model;
            this.Capacity = capacity;
            this.Multiprocessor = new List<CPU>();
        }

        public int Count => this.Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (this.Count < this.Capacity)
            {
                this.Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            var cpuToRemove = this.Multiprocessor.FirstOrDefault(cpu => cpu.Brand == brand);
            if (cpuToRemove != null)
            {
                this.Multiprocessor.Remove(cpuToRemove);
                return true;
            }
            return false;
        }

        public CPU MostPowerful()
        {
            return this.Multiprocessor.OrderByDescending(cpu => cpu.Frequency).FirstOrDefault();
        }

        public CPU GetCPU(string brand)
        {
            return this.Multiprocessor.FirstOrDefault(cpu => cpu.Brand == brand);
        }

        public string Report()
        {
            return $"CPUs in the Computer {this.Model}:\n{string.Join("\n", this.Multiprocessor)}";
        }
    }
}

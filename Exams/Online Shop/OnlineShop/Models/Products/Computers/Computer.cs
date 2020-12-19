
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly ICollection<IComponent> _components;
        private readonly ICollection<IPeripheral> _peripherals;
        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this._components = new List<IComponent>();
            this._peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => _components.ToList().AsReadOnly();
        public IReadOnlyCollection<IPeripheral> Peripherals => _peripherals.ToList().AsReadOnly();

        public override double OverallPerformance => CalculateOverallPerformance();
        public override decimal Price =>
            this.Peripherals.Sum(x => x.Price) + this.Components.Sum(x => x.Price)+ base.Price;

        private double CalculateOverallPerformance()
        {
            if (this.Components.Count == 0)
            {
                return base.OverallPerformance;
            }
            var result = base.OverallPerformance + this.Components.Average(x => x.OverallPerformance);

            return result;
        }



        public void AddComponent(IComponent component)
        {
            if (this._components.Any(x => x.GetType() == component.GetType()))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }
            this._components.Add(component);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (!this._components.Any(x => x.GetType().Name == componentType))
            {
                throw  new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent,componentType,this.GetType().Name,this.Id));
            }

            var component = this._components.FirstOrDefault(x => x.GetType().Name == componentType);
            this._components.Remove(component);
            return component;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (this._peripherals.Any(x => x.GetType() == peripheral.GetType()))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }
            this._peripherals.Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (!this._peripherals.Any(x => x.GetType().Name == peripheralType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }

            var peripheral = this._peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);
            this._peripherals.Remove(peripheral);
            return peripheral;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(
                $"Overall Performance: {this.OverallPerformance:f2}. Price: {this.Price:f2} - {this.GetType().Name}" +
                $": {this.Manufacturer} {this.Model} (Id: {this.Id})");
            sb.AppendLine($" Components ({this.Components.Count}):");

            foreach (var itemComponent in _components)
            { 
                sb.AppendLine($"  {itemComponent}");
            }

            string averageResult = this.Peripherals.Count == 0
                ? "0.00"
                : this.Peripherals.Average(x => x.OverallPerformance).ToString("F2");

            sb.AppendLine(
                $" Peripherals ({this.Peripherals.Count}); " +
                $"Average Overall Performance ({averageResult}):");

            foreach (var peripheral in _peripherals)
            {
                sb.AppendLine($"  {peripheral}");
            }
            return sb.ToString();
        }
    }
}

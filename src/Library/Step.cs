//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
            this.EquipmentCost = equipment.HourlyCost * time;
            this.MaterialCost = input.UnitCost * quantity;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        /*
        <summary>
        Como Step debe contener la informacion completa de cada Step, segun Expert deberia conocer la informacion del
        costo de realizar el Step
        </summary>
        */
        public double EquipmentCost { get;}

        public double MaterialCost { get;}
    }
}
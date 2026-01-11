using OpenEPAYT.Network.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OpenEPAYT.Network
{
    public class SimulationSettings
    {
        public SimulationSettings()
        {
            // DEFINIÇÃO DOS PARÂMETROS DE SIMULAÇÃO INICIAL
            Units = FlowUnitType.LPS;
            HeadLoss = HeadLossType.Hazen_Williams;
            Quality = QualityType.NONE;
            Viscosity = 1.0f;
            Trials = 40;
            Accuracy = 0.001;
            Unbalanced = UnbalancedType.Stop;
            DemandMultiplier = 1.0;
            EmmiterExponent = 0.5;
            MaxCheck = 10;
            CheckFrequency = 2;
            Diffusivity = 1.0;
            Tolerance = 0.01;
            Pattern = string.Empty;
        }

        public FlowUnitType Units { get; set; }
        public HeadLossType HeadLoss { get; set; }
        public QualityType Quality { get; set; }
        public float Viscosity { get; set; }
        public double SpecificGravity { get; set; }
        public int Trials { get; set; }
        public double Accuracy { get; set; }
        public UnbalancedType Unbalanced { get; set; }
        public string Pattern { get; set; }
        public double DemandMultiplier { get; set; }
        public double EmmiterExponent { get; set; }
        public string Map { get; set; }
        public double Tolerance { get; set; }
        public int CheckFrequency { get; set; }
        public int MaxCheck { get; set; }
        public int DampLimit { get; set; }
        public double Diffusivity { get; set; }

        public string ExportSection()
        {
            string TextTemplate = "[OPTIONS]";
            TextTemplate += Environment.NewLine + $"Units {Units}";
            TextTemplate += Environment.NewLine + $"Headloss {HeadLoss}";
            TextTemplate += Environment.NewLine + $"Specific Gravity {SpecificGravity}";
            TextTemplate += Environment.NewLine + $"Viscosity {Viscosity}";
            TextTemplate += Environment.NewLine + $"Trials {Trials}";
            TextTemplate += Environment.NewLine + $"Accuracy {Accuracy}";
            TextTemplate += Environment.NewLine + $"CHECKFREQ {CheckFrequency}";
            TextTemplate += Environment.NewLine + $"MAXCHECK {MaxCheck}";
            TextTemplate += Environment.NewLine + $"DAMPLIMIT {DampLimit}";
            switch (Unbalanced)
            {
                case UnbalancedType.Continue:
                    TextTemplate += Environment.NewLine + $"Unbalanced CONTINUE {MaxCheck}";
                    break;
                case UnbalancedType.Stop:
                    TextTemplate += Environment.NewLine + "Unbalanced STOP";
                    break;
            }
            TextTemplate += Environment.NewLine + $"Pattern {Pattern}";
            TextTemplate += Environment.NewLine + $"Demand Multiplier {DemandMultiplier}";
            TextTemplate += Environment.NewLine + $"Emitter Exponent {EmmiterExponent}";

            if (Quality != QualityType.NONE)
            {
                // DEFINIR LÓGICA DE EXPORTAÇÃO DE QUALIDADE 
            }
            else
            {
                TextTemplate += Environment.NewLine + $"Quality {Quality}";
            }
            TextTemplate += Environment.NewLine + $"Diffusivity {Diffusivity}";
            TextTemplate += Environment.NewLine + $" Tolerance {Tolerance}";
            return TextTemplate;
        }
    }
}

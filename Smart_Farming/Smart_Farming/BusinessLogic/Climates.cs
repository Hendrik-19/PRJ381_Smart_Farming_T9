using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    class Climates
    {
        int climateId;
        string climateName;
        double avgMaxTemp, avgMinTemp, avgPercipitation;

        public Climates(int climateId, string climateName, double avgMaxTemp, double avgMinTemp, double avgPercipitation)
        {
            ClimateId = climateId;
            ClimateName = climateName;
            AvgMaxTemp = avgMaxTemp;
            AvgMinTemp = avgMinTemp;
            AvgPercipitation = avgPercipitation;
        }

        public int ClimateId { get => climateId; set => climateId = value; }
        public string ClimateName { get => climateName; set => climateName = value; }
        public double AvgMaxTemp { get => avgMaxTemp; set => avgMaxTemp = value; }
        public double AvgMinTemp { get => avgMinTemp; set => avgMinTemp = value; }
        public double AvgPercipitation { get => avgPercipitation; set => avgPercipitation = value; }

        public override bool Equals(object obj)
        {
            return obj is Climates climates &&
                   climateId == climates.climateId &&
                   climateName == climates.climateName &&
                   avgMaxTemp == climates.avgMaxTemp &&
                   avgMinTemp == climates.avgMinTemp &&
                   avgPercipitation == climates.avgPercipitation;
        }

        public override int GetHashCode()
        {
            int hashCode = 1697169136;
            hashCode = hashCode * -1521134295 + climateId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(climateName);
            hashCode = hashCode * -1521134295 + avgMaxTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + avgMinTemp.GetHashCode();
            hashCode = hashCode * -1521134295 + avgPercipitation.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

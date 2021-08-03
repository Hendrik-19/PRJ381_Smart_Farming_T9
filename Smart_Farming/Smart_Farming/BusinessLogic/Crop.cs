using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Farming.BusinessLogic
{
    public class Crop
    {
        #region Crop
        // private fields
        private string name, location, description, addInfo;

        // public properties
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Description { get => description; set => description = value; }
        public string AddInfo { get => addInfo; set => addInfo = value; }

        // public constructor
        public Crop(string name, string location, string description, string addInfo)
        {
            this.name = name;
            this.location = location;
            this.description = description;
            this.addInfo = addInfo;
        }

        // Empty constructor for instance creation
        public Crop()
        {

        }

        // Equals override
        public override bool Equals(object obj)
        {
            return obj is Crop crop &&
                   name == crop.name &&
                   location == crop.location &&
                   description == crop.description &&
                   addInfo == crop.addInfo;
        }

        // HashCode override
        public override int GetHashCode()
        {
            int hashCode = -130549067;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(location);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(addInfo);
            return hashCode;
        }

        // toString override
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}

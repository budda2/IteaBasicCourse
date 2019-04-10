namespace Zoo
{
    public class Aviary
    {
        private Animal _animal;
        private Plant _plant;

        public bool IsClean { get; set; }
        public void PlaxeAnimal(Animal animal)
        {
            _animal = animal;
        }

        public void PlacePlant(Plant plant)
        {
            _plant = plant;
        }

        public string GetStatus()
        {
            if (_animal != null)
                return "Animal is inside";

            if (_plant != null)
                return "Plany is here";

            return "Empty";
        }
    }
}

using System.Text;

namespace ShoeStore
    {
    public class ShoeStore
        {
        public ShoeStore(string name, int storageCamacity)
            {
            Name = name;
            StorageCamacity = storageCamacity;
            Shoes = new List<Shoe>();
            }

        public string Name { get; set; }
        public int StorageCamacity { get; set; }
        public List<Shoe> Shoes { get; set; }

        public int Count()
            {
            return Shoes.Count;
            }
        public string AddShoe(Shoe shoe)
            {
            if (StorageCamacity == Shoes.Count)
                {
                return "No more space in the storage room.";
                }
            Shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        public int RemoveShoes(string material)
            {
            List<Shoe> shoesToRemove = Shoes;
            int removed = 0;
            for (int i = 0; i < shoesToRemove.Count; i++)
                { 
                Shoe currentShoue = shoesToRemove[i];
                if (currentShoue.Material == material)
                    {
                    Shoes.Remove(currentShoue);
                    i--;
                    removed++;
                    }
                }

            return removed;
            }
        public List<Shoe> GetShoesByType(string type)
            {
            List<Shoe> shoes = new List<Shoe>();
            foreach (var shoe in Shoes)
                {
                if (shoe.Type == type.ToLower())
                    {
                    shoes.Add(shoe);
                    }
                }
            return shoes;
            }
        public Shoe GetShoeBySize(double size)
            {
            foreach (var shoe in Shoes)
                {
                if (shoe.Size == size)
                    {
                    return shoe;
                    }
                }
            return null;
            }
        public string StockList(double size, string type)
            {
            bool atLeastOneMatch = false;
            StringBuilder shoes = new();
            shoes.AppendLine($"Stock list for size {size:f1} - {type} shoes:");
            foreach (var shoe in Shoes)
                {
                if (shoe.Type == type && shoe.Size == size)
                    {
                    shoes.AppendLine(shoe.ToString());
                    atLeastOneMatch = true;
                    }
                }
            if (atLeastOneMatch)
                {
                return shoes.ToString().Trim();
                }
            return "No matches found!";
            }
        }
    }

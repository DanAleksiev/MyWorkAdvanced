using System.Linq;
using System.Text;

namespace ShoeStore
    {
    public class ShoeStore
        {
        private List<Shoe> shoes;
        public ShoeStore(string name, int storageCamacity)
            {
            Name = name;
            StorageCamacity = storageCamacity;
            shoes = new List<Shoe>();
            }

        public string Name { get; set; }
        public int StorageCamacity { get; set; }
        public IReadOnlyCollection<Shoe> Shoe => shoes;
        public int Count => shoes.Count;
        public string AddShoe(Shoe shoe)
            {
            if (shoes.Count == StorageCamacity)
                {
                return "No more space in the storage room.";
                }
            shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        public int RemoveShoes(string material)
            => shoes.RemoveAll(s => s.Material == material);
        public List<Shoe> GetShoesByType(string type)
            => shoes.FindAll(s => s.Type.ToLower() == type.ToLower());
        public Shoe GetShoeBySize(double size)
            => shoes.FirstOrDefault(s=> s.Size == size);
        public string StockList(double size, string type)
            {
            IEnumerable<Shoe> stockList = shoes
                .Where(s => s.Size == size && s.Type == type);

            StringBuilder shoesSB = new();

            if (!stockList.Any())
                {
                return "No matches found!";
                }
            else
                {
                shoesSB.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var stock in stockList)
                    {
                    shoesSB.AppendLine(stock.ToString());
                    }
                }
            return shoesSB.ToString().Trim();
            }
        }
    }

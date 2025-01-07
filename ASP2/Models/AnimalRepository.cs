namespace ASP2.Models
{
    public class AnimalRepository
    {
        public static List<Animal> Animals = new List<Animal>
        {
            new Animal { Name = "Собака", Description = "Лояльний та вірний друг.", Type = "Pet" },
            new Animal { Name = "Кішка", Description = "Грайливий домашній улюбленець.", Type = "Pet" },
            new Animal { Name = "Папуга", Description = "Розумний та барвистий.", Type = "Pet" },
            new Animal { Name = "Лев", Description = "Цар звірів.", Type = "Wild" },
            new Animal { Name = "Вовк", Description = "Мешкає в лісах.", Type = "Wild" },
            new Animal { Name = "Орел", Description = "Горда пташка.", Type = "Wild" }
        };
    }
}

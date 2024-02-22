namespace Creational
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        public class PersonBuilder : PersonJobBuilder<PersonBuilder>
        {
        }

        public static PersonBuilder New => new PersonBuilder();
    }

    public abstract class BasePersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }

    public class PersonInfoBuilder<T> : BasePersonBuilder where T : PersonInfoBuilder<T>
    {
        public T Called(string name)
        {
            person.Name = name;
            return (T)this;
        }
    }

    public class PersonJobBuilder<T> : PersonInfoBuilder<PersonJobBuilder<T>>
        where T : PersonJobBuilder<T>
    {
        public PersonJobBuilder<T> WorksAsA(string position)
        {
            person.Position = position;
            return this;
        }
    }
}
public enum FactoryType
{
	Human,
	Animal
}
public enum HumanType
{
	Farmer,
	Beggar,
	Shopowner
}
public enum AnimalType
{
	Dog,
	Cat
}
public interface IHuman
{
	void Speak();
}
public interface IAnimal
{
	void Voice();
}
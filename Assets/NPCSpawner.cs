using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    private IHuman m_Farmer;
    private IHuman m_Beggar;
    private IHuman m_Shopowner;
    private IHuman m_Guard;

    private IAnimal m_Dog;
    private IAnimal m_Cat;
    private AbstractFactory factory;
    public Environment env;

    public void SpawnAnimals()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Animal);
        if(!(env.time.text == "9:00 AM") && (env.isRaining == false))
        {
            m_Cat = factory.GetAnimal(AnimalType.Cat);
            m_Cat.Voice();
            GameObject catInstance = Instantiate(Resources.Load("Cat", typeof(GameObject))) as GameObject;
            catInstance.transform.position = new Vector3((Random.Range(-10f, 10f)), 0, 0);
        }
        else
        {
            m_Dog = factory.GetAnimal(AnimalType.Dog);
            m_Dog.Voice();
            GameObject dogInstance = Instantiate(Resources.Load("Dog", typeof(GameObject))) as GameObject;
            dogInstance.transform.position = new Vector3((Random.Range(-10f, 10f)), 0, 0);
        }
    }
    public void SpawnHumans()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Human);
        if(!(env.time.text == "9:00 AM") && (env.isRaining == false))
        {
            m_Beggar = factory.GetHuman(HumanType.Beggar);
            m_Beggar.Speak();
            GameObject beggarInstance = Instantiate(Resources.Load("Beggar", typeof(GameObject))) as GameObject;
            beggarInstance.transform.position = new Vector3((Random.Range(-10f, 10f)), 0, 0);
        }
        if(!(env.time.text == "10:00 PM"))
        {
            m_Farmer = factory.GetHuman(HumanType.Farmer);
            m_Farmer.Speak();
            GameObject farmerInstance = Instantiate(Resources.Load("Farmer", typeof(GameObject))) as GameObject;
            farmerInstance.transform.position = new Vector3((Random.Range(-10f, 10f)), 0, 0);
        }
        if(env.isRaining == false)
        {
            m_Shopowner = factory.GetHuman(HumanType.Shopowner);
            m_Shopowner.Speak();
            GameObject shopownerInstance = Instantiate(Resources.Load("Shopkeeper", typeof(GameObject))) as GameObject;
            shopownerInstance.transform.position = new Vector3((Random.Range(-10f, 10f)), 0, 0);
        }
        
        
    }
}

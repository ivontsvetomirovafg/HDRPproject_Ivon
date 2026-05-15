using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class Item : ScriptableObject
{
    public enum ObjectType {  Weapon, Armor, Consumable}

    public Sprite objectImage;
    public string nombre;
    public ObjectType objectType;
    public float value;
}

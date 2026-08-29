using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/UnitData")]
public class UnitData : ScriptableObject
{
    [SerializeField] private string _unitName;
    [SerializeField] private int _health;
    [SerializeField] private float _speed;

    public string unitName => this._unitName;
    public int health => this._health;
    public float speed => this._speed;
}
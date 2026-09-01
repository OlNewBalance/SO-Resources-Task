using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/UnitData")]
public class UnitData : ScriptableObject
{
    [SerializeField] private string _unitName;
    [SerializeField] private int _health;
    [SerializeField] private float _speed;

    public string UnitName => _unitName;
    public int Health => _health;
    public float Speed => _speed;
}
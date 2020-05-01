using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.SlotModules.GunParticles
{
    public class Bullets : IGunParticles
    {
        [SerializeField] private float _damage = 50;
        [SerializeField] private float _range = 250;

        public float Damage { get => _damage; set { _damage = value; } }
        public float Range { get => _range; set { _range = value; } }
    }
}
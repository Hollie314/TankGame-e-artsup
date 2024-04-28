using UnityEngine;

namespace Script
{
    public class Cible : MonoBehaviour
    {
        [field: SerializeField] public Transform Cible1 { get; private set; }

        void Start()
        {
            Cible1 = GameObject.Find("TargetObject").transform;
        }

    }
}

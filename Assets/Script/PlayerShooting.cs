using UnityEngine;

namespace Script
{
    public class PlayerShooting : MonoBehaviour
    {
        public Transform firePoint; // Point d'où le projectile sera tiré
        public GameObject projectilePrefab; // Le prefab du projectile

        void Update()
        {
            if (Input.GetMouseButtonDown(0)) // 0 correspond au bouton gauche de la souris
            {
                Shoot();
            }
        }

        void Shoot()
        {
            // Crée une instance du projectile au firePoint
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
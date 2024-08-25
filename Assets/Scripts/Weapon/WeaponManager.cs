using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public WeaponData currentWeapon;
    public Transform firePoint; // �����, ������ ����� ����������� ��������
    public GameObject bulletPrefab; // ������ ����

    private float fireRate;
    private float nextFireTime;

    void Start()
    {
        if (currentWeapon != null)
        {
            fireRate = currentWeapon.fireRate;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time >= nextFireTime)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}

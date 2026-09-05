using UnityEngine;

public class SpawnBola : MonoBehaviour
{
    public GameObject bolaLeve;
    public GameObject bolaPesada;
    public Transform pontoDeSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Instantiate(bolaLeve, pontoDeSpawn.position, Quaternion.identity);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            Instantiate(bolaPesada, pontoDeSpawn.position, Quaternion.identity);
    }
}

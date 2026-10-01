using UnityEngine;

public class GeneradorMeteorits : MonoBehaviour
{

    public GameObject meteoritPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GeneradorMeteorit", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GeneradorMeteorit();
    {
        GameObject meteroitGenerat = Instantiate(meteoritPrefab);

        meteroitGenerat.transform.position = new Vector3(
            Random.Range(ValorsGlobals.LimitEsquerraX, ValorsGlobals.LimitDretaX),
            Random.Range(ValorsGlobals.LimitInferiorY, ValorsGlobals.LimitSuperiorY),
            ValorsGlobals.LimitZPositiu
        );
    }
}

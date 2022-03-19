using TMPro;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private TMP_InputField speed;
    [SerializeField] private TMP_InputField distance;
    [SerializeField] private TMP_InputField timeSpawn;

    public void SetNewParamsSpawn()
    {
        SpawnController.Instance.StartNewSpawn(float.Parse(speed.text), 
            float.Parse(timeSpawn.text), float.Parse(distance.text));
    }
}

using UnityEngine;
using TMPro;

public class WaveManager : MonoBehaviour
{
    [Header("Wave Number")]
    public int waveNumber;
    public TextMeshProUGUI waveNumberDisplay;

    [Header("Wave Cooldown")]
    public bool waveActive;
    float waveCooldownTimer = 1f;
    public TextMeshProUGUI waveCooldownDisplay;
    public GameObject waveCooldownPanel;

    void NewWave()
    {
        waveNumberDisplay.text = waveNumber.ToString();
    }

    void FixedUpdate()
    {
        waveCooldownTimer -= 1 * Time.fixedDeltaTime;
        waveCooldownDisplay.text = Mathf.Ceil(waveCooldownTimer).ToString();
        
        if(waveCooldownTimer <= 0)
        {
            waveCooldownTimer = 0;
            waveActive = true;
            waveCooldownPanel.SetActive(false);
        } else {
            waveCooldownPanel.SetActive(true);
        }


    }
}

using UnityEngine;

public class LevelActivator : MonoBehaviour
{
    public GameObject[] _levelNumber;

    private void Start()
    {
        for (int i = 0; i < _levelNumber.Length; i++)
            if (_levelNumber[i].activeSelf == true) { _levelNumber[i].SetActive(false); break; }

        int levelNumberActivate = PlayerPrefs.GetInt("lvl");
        _levelNumber[levelNumberActivate-1].SetActive(true);
    }
}

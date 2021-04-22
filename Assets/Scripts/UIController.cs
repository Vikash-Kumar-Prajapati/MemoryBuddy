using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
	public TMP_Text countText;

	int movesCount;

    // Start is called before the first frame update
    void Start()
    {

		countText.text = "0";
    }


	public void ChangeMovesCount(int movesCount)
	{
		this.movesCount = movesCount;
		countText.text = movesCount.ToString();
	}

}

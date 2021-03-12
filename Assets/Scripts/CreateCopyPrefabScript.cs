using UnityEngine;
using System.Collections;

public class CreateCopyPrefabScript : MonoBehaviour
{
	// 生成したいPrefab
	public GameObject Prefab1;
	public GameObject Prefab2;

	// Prefab用の配列
	GameObject[] PrefabArray;

	// クリックした位置座標
	private Vector3 clickPosition;

	// 複製したプレハブ
	private GameObject CopyPrefab;

	// 複製したプレハブの重力制御用
	private Rigidbody rBody;

	// クリック中かの判断
	private bool buttonDownFlag = false;

	// Start is called before the first frame update
	void Start()
	{
		PrefabArray = new GameObject[] { Prefab1, Prefab2 };
	}

	// Update is called once per frame
	void Update()
	{
		if (buttonDownFlag)
		{
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;
			CopyPrefab.transform.position = Camera.main.ScreenToWorldPoint(clickPosition);
		}

		if (Input.GetMouseButtonDown(0))
		{
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;

			int rand = Random.Range(0, 2);
			CopyPrefab = Instantiate(PrefabArray[rand], Camera.main.ScreenToWorldPoint(clickPosition), PrefabArray[rand].transform.rotation);

			buttonDownFlag = true;
		}

		if (Input.GetMouseButtonUp(0))
		{
			rBody = CopyPrefab.GetComponent<Rigidbody>();
			rBody.useGravity = true;

			buttonDownFlag = false;
		}
	}
}
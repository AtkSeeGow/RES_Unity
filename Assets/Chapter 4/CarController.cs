using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;

    Vector2 startPosition;  // 滑鼠左鍵點擊時的位置

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 如果左鍵被按下
            this.startPosition = Input.mousePosition;  // 將目前滑鼠的位置放到變數中

        if(Input.GetMouseButtonUp(0))
        {
            var endPosition = Input.mousePosition;

            float swipeLength = endPosition.x - startPosition.x;

            speed = swipeLength / 500.0f;

            this.audioSource.Play();
        }

        this.transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}

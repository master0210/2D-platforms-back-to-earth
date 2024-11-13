using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PressMove : MonoBehaviour
{
    public float ButtonMoveForce = 5f;
    public bool moveRight = false; // Kiểm tra xem button này có phải để di chuyển sang phải hay không
    public bool moveLeft = false;


    // Hàm này gọi khi nhấn giữ nút sang phải
    public void MoveRight()
    {
        moveRight = true;
    }

    // Hàm này gọi khi nhấn giữ nút sang trái
    public void MoveLeft()
    {
        moveLeft = true;
    }

    // Hàm này gọi khi thả nút sang phải
    public void StopRight()
    {
        moveRight = false;
    }

    // Hàm này gọi khi thả nút sang trái
    public void StopLeft()
    {
        moveLeft = false;
    }

    void Update()
    {
        // Giữ rotation trên trục Y cố định
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z);

        if (moveRight)
        {
            transform.Translate(Vector3.right * ButtonMoveForce * Time.deltaTime);
        }

        if (moveLeft)
        {
            transform.Translate(Vector3.left * ButtonMoveForce * Time.deltaTime);
        }
    }

}



using UnityEngine;

public class Lab1_SoundControl : MonoBehaviour
{
    // Tạo biến để chứa cái AudioSource
    private AudioSource caiLoa;

    void Start()
    {
        // Lệnh này tự động tìm component AudioSource gắn trên cùng object này
        caiLoa = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 1. Nhấn phím Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play(): Phát nhạc từ đầu
            // PlayOneShot(clip): Phát đè lên nhau (thích hợp tiếng súng liên thanh)
            // Ở đây dùng Play() cơ bản
            caiLoa.Play();
            Debug.Log("Đang phát nhạc!"); // Dòng này để kiểm tra ở Console
        }

        // 2. Nhấn phím S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            caiLoa.Stop();
            Debug.Log("Đã tắt nhạc!");
        }
    }
}
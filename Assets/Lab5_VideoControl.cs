using UnityEngine;
using UnityEngine.Video; // BẮT BUỘC PHẢI CÓ DÒNG NÀY

public class Lab5_VideoControl : MonoBehaviour
{
    public VideoPlayer myVideoPlayer; // Biến chứa cái đầu đĩa

    void Start()
    {
        // Tự động tìm component VideoPlayer gắn trên cùng object này
        myVideoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        // Nhấn phím V để Bật/Tắt video
        if (Input.GetKeyDown(KeyCode.V))
        {
            // Kiểm tra: Nếu đang chạy thì Pause, nếu đang dừng thì Play
            if (myVideoPlayer.isPlaying)
            {
                myVideoPlayer.Pause();
                Debug.Log("Video: Tạm dừng (Pause)");
            }
            else
            {
                myVideoPlayer.Play();
                Debug.Log("Video: Đang phát (Play)");
            }
        }
    }
}
using UnityEngine;
using UnityEngine.Video; // Thư viện Video
using UnityEngine.SceneManagement; // Thư viện chuyển Scene (nếu cần)

public class Lab7_EventManager : MonoBehaviour
{
    public VideoPlayer myVideo;
    public GameObject endUI; // Panel UI cần hiện

    void Start()
    {
        // --- ĐĂNG KÝ SỰ KIỆN (SUBSCRIBE) ---
        // Cú pháp: [Tên_Biến]. sự_kiện += [Tên_Hàm_Xử_Lý];
        
        // 1. Khi video load xong dữ liệu
        myVideo.prepareCompleted += OnVideoPrepared;

        // 2. Khi video chạy hết (đến điểm lặp)
        myVideo.loopPointReached += OnVideoEnded;

        // Bắt đầu load video (Nếu chưa play)
        myVideo.Prepare();
    }

    // Hàm này tự chạy khi video load xong
    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video đã sẵn sàng! Bắt đầu phát.");
        vp.Play(); // Load xong thì tự play luôn
    }

    // Hàm này tự chạy khi hết video
    void OnVideoEnded(VideoPlayer vp)
    {
        Debug.Log("Video đã kết thúc.");
        
        // CÁCH 1: Hiện UI
        if (endUI != null)
        {
            endUI.SetActive(true); // Bật cái Panel lên
        }

        // CÁCH 2: Chuyển Scene (Mở comment nếu muốn dùng)
        // SceneManager.LoadScene("Ten_Scene_GamePlay");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện quản lý Scene
using UnityEngine.Video;           // Thư viện quản lý Video

public class IntroManager : MonoBehaviour
{
    [Header("Cấu hình")]
    public VideoPlayer myVideo;              // Biến chứa Video Player
    public AudioSource backgroundMusic;      // Biến chứa nhạc nền (nếu có)
    public string sceneToLoad = "GameScene"; // Tên Scene sẽ chuyển đến

    void Start()
    {
        // Đăng ký sự kiện: Khi video chạy hết thì gọi hàm EndVideo
        myVideo.loopPointReached += EndVideo;
    }

    // 1. Hàm này tự chạy khi video hết
    void EndVideo(VideoPlayer vp)
    {
        Debug.Log("Video hết -> Chuyển cảnh");
        StartGameplay(); // Gọi hàm chung để chuyển cảnh
    }

    // 2. Hàm này gắn vào nút Skip
    public void SkipClicked()
    {
        Debug.Log("Bấm Skip -> Chuyển cảnh");
        StartGameplay(); // Gọi hàm chung để chuyển cảnh
    }

    // 3. Hàm xử lý logic chuyển cảnh (Gộp chung vào đây cho gọn)
    void StartGameplay()
    {
        // --- BƯỚC QUAN TRỌNG: DỌN DẸP TRƯỚC KHI CHUYỂN ---
        
        // Dừng video (Sửa lỗi introVideo -> myVideo)
        if (myVideo != null) 
            myVideo.Stop(); 
        
        // Dừng nhạc nền (Nếu có gắn vào)
        if (backgroundMusic != null)
        {
            backgroundMusic.Stop();
        }

        // --- CHUYỂN SCENE ---
        SceneManager.LoadScene(sceneToLoad);
    }
}
using UnityEngine;

public class Lab3_GlobalControl : MonoBehaviour
{
    void Update()
    {
        // --- CHỨC NĂNG 1: MUTE / UNMUTE (Phím M) ---
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Kiểm tra xem Volume hiện tại có lớn hơn 0 không
            if (AudioListener.volume > 0)
            {
                // Nếu đang có tiếng -> Vặn về 0 (Tắt)
                AudioListener.volume = 0;
                Debug.Log("Đã Mute (Tắt toàn bộ tiếng)");
            }
            else
            {
                // Nếu đang tắt -> Vặn lên 1 (Mở lại max volume)
                AudioListener.volume = 1;
                Debug.Log("Đã Unmute (Mở lại tiếng)");
            }
        }

        // --- CHỨC NĂNG 2: PAUSE / RESUME (Phím P) ---
        if (Input.GetKeyDown(KeyCode.P))
        {
            // AudioListener.pause là biến kiểu bool (true/false)
            // Dấu ! nghĩa là đảo ngược (đang true thành false, đang false thành true)
            AudioListener.pause = !AudioListener.pause;
            
            if (AudioListener.pause)
                Debug.Log("Game Audio: Đã TẠM DỪNG (Paused)");
            else
                Debug.Log("Game Audio: Đã TIẾP TỤC (Resumed)");
        }
    }
}
using UnityEngine;

/// <summary>
/// リリースID4
/// 
/// デバックで使用するID4キャラクターを解放するスクリプト
/// </summary>
public class ReleaseID4 : MonoBehaviour
{
    [SerializeField] private SelectCharacterID selectCharacterID; // 選択キャラのID

    public void OnCheck()
    {
        selectCharacterID.canSelected = true;
    }
    
}

using UnityEngine;

/// <summary>
/// Noボタン
/// 
/// ゲーム終了をキャンセルするボタン
/// </summary>
public class NoButton : ButtonBase
{
    #region Config
    [SerializeField] private EndScreen endScreen; // 終了スクリーン
    #endregion

    public override void OnClick()
    {
        base.OnClick();
        endScreen.SetNoPressed();
    }
}

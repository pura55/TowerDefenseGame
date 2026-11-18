using UnityEngine;

/// <summary>
/// エンドボタン
/// 
/// ゲーム終了の選択を表示するボタン
/// </summary>
public class EndButton : ButtonBase
{
    #region State
    [SerializeField] private EndScreen endScreen; // 終了スクリーン
    #endregion

    public override void OnClick()
    {
        base.OnClick();
        endScreen.SetEndPressed();
    }
}

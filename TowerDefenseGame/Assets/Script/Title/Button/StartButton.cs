using UnityEngine;

/// <summary>
/// スタートボタン
/// 
/// ゲーム開始ボタン
/// </summary>
public class StartButton : ButtonBase
{
    #region Config
    [SerializeField] private SelectAnimation selectAnimation; // キャラクターのアニメーション
    [SerializeField] private SelectCharacterID selectCharacterID; // 選択したキャラクターのID
    [SerializeField] private SelectedExclamation selectExclamation; // 選択時の注意
    [SerializeField] private GameManager gameManager; // ゲームマネージャー
    #endregion

    #region State
    private int rockCharacterID = 4; // ロックがかかっているキャラクターのＩＤ
    #endregion

    public override void OnClick()
    {
        base.OnClick();

        // 解放されていないキャラクターを選択した場合注意を表示します
        if (selectAnimation.GetCharacterID() == rockCharacterID && !selectCharacterID.canSelected)
        {
            selectExclamation.SetAlpha();
            return;
        }

        // idを設定
        selectCharacterID.SetSelectID(selectAnimation.GetCharacterID());

        // シーン遷移
        gameManager.ChangeMainGame();
        return;
    }
}

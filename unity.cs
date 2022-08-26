using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class スクリプト : MonoBehaviour
{
    void Start() // 1フレーム目
    {
        処理;
    }

    void Update() // 2フレーム目～
    {
        処理;
    }
}


// コメント

1 // 整数
1.0f // 小数
true/false // 真偽値
"A" // 文字列
void // 型無し

+ - * / // 算術演算子
== != < <= > >= // 比較演算子
& | ! // 論理演算子

if (条件) // 分岐
{
    処理;
}
else if (条件)
{
    処理;
}
else
{
    処理;
}

for (初期化; 条件; 更新) // 回数ループ
{
    処理;
    continue;
    break;
}

foreach (型 変数 in 配列) // 配列ループ
{
    処理;
    continue;
    break;
}

while (条件) // 条件ループ
{
    処理;
    continue;
    break;
    更新;
}

型 変数 = 値; // 変数
変数 = 値;
変数

型[] 配列 = {値}; // 配列
配列
配列[インデックス]

戻り値の型 メソッド(型 引数) // メソッド
{
    処理;
    return 戻り値;
}
メソッド(引数);

class クラス // クラス
{
    public 型 メンバ変数 = 値;

    public 戻り値の型 メンバメソッド(型 引数)
    {
        処理;
        return 戻り値;
    }
}
クラス インスタンス = new クラス();
インスタンス.メンバ変数;
インスタンス.メンバメソッド(引数);

using パッケージ; // パッケージ

﻿using UnityEngine;
using UnityEngine.UI;

public class Secondui : MonoBehaviour {

    public Button btn_msg;
    public Button btn_trans;
    public Button btn_anim;
    public Button btn_clean;
    private LWindowManager _wm;
    protected Animator _teddyAnim;

    void Start() {

        _wm = LWindowManager.GetInstance();
        _teddyAnim = GameObject.Find("Teddy").GetComponent<Animator>();

        btn_msg.onClick.AddListener(() =>
        {
            _wm.runWindow("MsgBox.prefab", WindowHierarchy.Normal);
        });

        btn_trans.onClick.AddListener(() =>
        {
            _wm.LoadScene("first");
        });

        btn_anim.onClick.AddListener(() =>
        {
            _teddyAnim.SetBool("run_idle", false);
            _teddyAnim.SetBool("idle_run", true);
        });

        btn_clean.onClick.AddListener(() =>
        {
            _teddyAnim.SetBool("idle_run", false);
            _teddyAnim.SetBool("run_idle", true);
        });
	}
}

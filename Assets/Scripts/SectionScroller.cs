﻿using UnityEngine;

/*
 * Attached to the section so that everything will scroll sideways.
 * The player does not move in this game, the environment does.
 */
public class SectionScroller : MonoBehaviour
{
  /*
   * Use the Transform component attached to the section game object and
   * translate it based on delta time.
   */
  private void Update()
  {
    transform.Translate(new Vector2(-1.5f, 0) * Time.deltaTime);
  }
}

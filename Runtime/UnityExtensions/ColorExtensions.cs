using UnityEngine;

namespace BenizKit.Extensions {

  public static class ColorExtensionMethods {

    public static Color WithRed(this Color color, float red) {
      return new Color(red, color.g, color.b, color.a);
    }

    public static Color WithGreen(this Color color, float green) {
      return new Color(color.r, green, color.b, color.a);
    }

    public static Color WithBlue(this Color color, float blue) {
      return new Color(color.r, color.g, blue, color.a);
    }

    public static Color WithAlpha(this Color color, float alpha) {
      return new Color(color.r, color.g, color.b, alpha);
    }
  }

}

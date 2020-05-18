IEnumerator HorizontalRock() {

        yield return null;

        rotationAngleY += InputThrottle * HorizontalRockSpeed;

        var horizontalRotation = Mathf.Sin(rotationAngleY) * HorizontalRockAmt * 1.5f;

        transform.localRotation = Quaternion.Euler(0, horizontalRotation, 0);

        horizontalRock = true;
    }
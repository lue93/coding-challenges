package utils;

public class Lasagna extends ReflectionProxy {

    private static final int MINUTES_IN_OVEN = 40;
    private static final int PREPARE_TIME_PER_LAYER = 2;

    @Override
    public String getTargetClassName() {
        return "Lasagna";
    }

    public int expectedMinutesInOven() {
            return MINUTES_IN_OVEN;
    }

    public int remainingMinutesInOven(int actualMinutes) {
            return MINUTES_IN_OVEN - actualMinutes;
    }

    public int preparationTimeInMinutes(int amountLayers) {
         return amountLayers * PREPARE_TIME_PER_LAYER;
    }

    public int totalTimeInMinutes(int amountLayers, int actualMinutes) {
        return preparationTimeInMinutes(amountLayers) + actualMinutes;
    }

}

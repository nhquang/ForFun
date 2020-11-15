//https://leetcode.com/problems/design-parking-system/

public class ParkingSystem {
    readonly int big_;
    readonly int medium_;
    readonly int small_;
    int bigOccupied_ = 0;
    int mediumOccupied_ = 0;
    int smallOccupied_ = 0;

    public ParkingSystem(int big, int medium, int small) {
        big_ = big;
        medium_ = medium;
        small_ = small;
    }
    
    public bool AddCar(int carType) {
        if(carType == 1 && bigOccupied_ < big_){
            bigOccupied_++;
            return true;
        }
        else if(carType == 2 && mediumOccupied_ < medium_) { mediumOccupied_++; return true;}
        else if(carType == 3 && smallOccupied_ < small_) {smallOccupied_++; return true;}
        return false;
    }
}
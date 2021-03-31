using System;

namespace GameOfLife
{
    internal class Worm
    {
        private int positionX;
        private int positionY;
        private Boolean alive;
        private int age;
        private int deadTime;

        public Worm(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public void setAlive()
        {
            this.alive = true;
            this.deadTime = -1;
            this.age = 0;
        }

        public void setDead()
        {
            this.alive = false;
            this.deadTime = 0;
            this.age = 0;
        }

        public Boolean isAlive()
        {
            return this.alive;
        }

        public void increaseAge()
        {
            this.age++;
        }

        public void increaseDeadTime()
        {
            this.deadTime++;
        }

        public int getAge()
        {
            return this.age;
        }

        public int getAliveNeighbours(Worm[,] worm)
        {
            int count = 0;

            if (worm[positionX - 1, positionY].isAlive()) count++;
            if (worm[positionX + 1, positionY].isAlive()) count++;
            if (worm[positionX, positionY - 1].isAlive()) count++;
            if (worm[positionX, positionY + 1].isAlive()) count++;

            if (worm[positionX - 1, positionY - 1].isAlive()) count++;
            if (worm[positionX + 1, positionY + 1].isAlive()) count++;
            if (worm[positionX - 1, positionY + 1].isAlive()) count++;
            if (worm[positionX + 1, positionY - 1].isAlive()) count++;

            return count;
        }

        public void evaluateLife(Worm[,] worm, int neighboursMin, int neighboursMax, int ageMax, int DeadtimeMax)
        {
            if (this.isAlive())
            {
                if (
                (this.getAliveNeighbours(worm) < neighboursMin) || (this.getAliveNeighbours(worm) > neighboursMax)
                ||
                (this.getAge() > ageMax)
                )
                {
                    this.setDead();
                }
                else
                {
                    this.increaseAge();
                }
            }
            else
            {
                if ((this.getAliveNeighbours(worm) >= neighboursMin) && (this.getAliveNeighbours(worm) <= neighboursMax))
                {
                    this.setAlive();
                }
                else
                {
                    if (this.deadTime > DeadtimeMax)
                    {
                        this.setAlive();
                    }
                    else
                    {
                        this.increaseDeadTime();
                    }
                }
            }

            /*
            if (
                (this.getAliveNeighbours(worm) >= neighboursMin) &&
                (this.getAliveNeighbours(worm) <= neighboursMax)
                )
            {
                this.setAlive();
            } else
            {
                this.setDead();
            }

            if (this.isAlive() ) this.increaseAge();
            if (!this.isAlive()) this.increaseDeadTime();

            if (this.age > ageMax)
            {
                this.setDead();
            }

            if (this.deadTime > DeadtimeMax)
            {
                this.setAlive();
            }*/
        }
    }
}
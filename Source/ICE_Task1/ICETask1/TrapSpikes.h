// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "TrapSpikes.generated.h"

UCLASS()
class ICE_TASK1_API ATrapSpikes : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	ATrapSpikes();

protected:
    UPROPERTY(VisibleAnywhere, Category = "Trap")
    UStaticMeshComponent* TrapMesh;

    UPROPERTY(VisibleAnywhere, Category = "Trap")
    class UBoxComponent* CollisionBox;

    // Function called when something overlaps
    UFUNCTION()
    void OnOverlapBegin(UPrimitiveComponent* OverlappedComp, AActor* OtherActor,
        UPrimitiveComponent* OtherComp, int32 OtherBodyIndex,
        bool bFromSweep, const FHitResult& SweepResult);

};

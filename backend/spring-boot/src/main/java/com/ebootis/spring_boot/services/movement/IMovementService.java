package com.ebootis.spring_boot.services.movement;

import com.ebootis.spring_boot.dtos.MovementDTO;
import com.ebootis.spring_boot.models.Movement;
import com.ebootis.spring_boot.services.generic.ICombinedGenericService;

public interface IMovementService extends ICombinedGenericService<Movement,MovementDTO,Integer> {

}

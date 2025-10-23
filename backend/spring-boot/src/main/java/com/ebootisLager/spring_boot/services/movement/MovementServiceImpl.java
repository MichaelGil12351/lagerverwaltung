package com.ebootis.spring_boot.services.movement;

import com.ebootis.spring_boot.dtos.MovementDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.Movement;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Service;

@Service
public class MovementServiceImpl extends CombinedGenericServiceImpl<Movement, MovementDTO,Integer> implements IMovementService {

    public MovementServiceImpl(JpaRepository<Movement, Integer> repository, IMapper<Movement, MovementDTO> mapper) {
        super(repository, mapper);
    }
}

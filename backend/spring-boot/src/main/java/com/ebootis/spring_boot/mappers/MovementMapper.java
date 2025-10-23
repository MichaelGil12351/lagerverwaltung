package com.ebootis.spring_boot.mappers;

import com.ebootis.spring_boot.dtos.MovementDTO;
import com.ebootis.spring_boot.models.Movement;
import com.ebootis.spring_boot.models.User;
import com.ebootis.spring_boot.repositories.IUserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.stream.Collectors;

@Component
public class MovementMapper implements IMapper<Movement, MovementDTO> {

    @Autowired
    private IUserRepository userRepository;

    @Autowired
    private ProcessPositionMapper processMapper;

    @Override
    public MovementDTO toDTO(Movement movement) {
//        if (movement == null) return null;
//
//        MovementDTO dto = new MovementDTO();
//        dto.setId(movement.getId());
//        dto.setQuantity(movement.getQuantity());
//
//        if (movement.getUser() != null) {
//            dto.setUserId(movement.getUser().getId());
//        }
//
//        if (movement.getProcesses() != null) {
//            dto.setProcesses(
//                    movement.getProcesses()
//                            .stream()
//                            .map(processMapper::toDTO)
//                            .collect(Collectors.toList())
//            );
//        }
//
//        return dto;
        return null;
    }

    @Override
    public Movement toEntity(MovementDTO dto) {
//        if (dto == null) return null;
//
//        Movement movement = new Movement();
//        movement.setQuantity(dto.getQuantity());
//
//        if (dto.getUserId() != null) {
//            User user = userRepository.findById(dto.getUserId()).orElse(null);
//            movement.setUser(user);
//        }
//
//        if (dto.getProcesses() != null) {
//            movement.setProcesses(
//                    dto.getProcesses()
//                            .stream()
//                            .map(processMapper::toEntity)
//                            .collect(Collectors.toList())
//            );
//        }

        return null;
    }
}
